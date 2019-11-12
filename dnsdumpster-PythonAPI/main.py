from flask import Flask
from flask_restful import Resource, Api
from dnsdumpster.DNSDumpsterAPI import DNSDumpsterAPI
import json

app = Flask(__name__)
api = Api(app)

dnsRecords = []
mxRecords = []
hostRecords = []
technologyFound = []
txtRecords = []

allRecords = []


class DnsDumpster(Resource):
    def get(self, hostUrl):

        allRecords = []

        res = DNSDumpsterAPI().search(hostUrl)

        ### Build return object
        for entry in res['dns_records']['dns']:
            dns = { "dns": "{domain} ({ip}) {as} {provider} {country}".format(**entry) }
            dnsRecords.append(dns)

        for entry in res['dns_records']['mx']:
            mx = { "mx" : "{domain} ({ip}) {as} {provider} {country}".format(**entry) }
            mxRecords.append(mx)

        for entry in res['dns_records']['host']:
            if entry['reverse_dns']:
                host = { "host": "{domain} ({reverse_dns}) ({ip}) {as} {provider} {country}".format(**entry) }
                hostRecords.append(host)
            else:
                host = { "host": "{domain} ({ip}) {as} {provider} {country}".format(**entry)}
                hostRecords.append(host)

        for entry in res['dns_records']['host']:
            if entry['header']:
                tech = { "tech": "{domain} {header}".format(**entry) }
                technologyFound.append(tech)

        for entry in res['dns_records']['txt']:
            txt = { "txt": entry }
            txtRecords.append(txt)

        returnObj = { 'dnsRecords': dnsRecords,
                        'mxRecords': mxRecords,
                        'hostRecords': hostRecords,
                        'techFound': technologyFound,
                        'txtRecords': txtRecords 
                    }
        
        return returnObj 

class HealthCheck(Resource):
    def get(self):
        return 'pong'

api.add_resource(DnsDumpster, '/scan/<string:hostUrl>')
api.add_resource(HealthCheck, '/ping')

api.init_app(app)

if __name__ == '__main__':
    app.run()