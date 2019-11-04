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
            dnsRecords.append("{domain} ({ip}) {as} {provider} {country}".format(**entry))

        for entry in res['dns_records']['mx']:
            mxRecords.append("{domain} ({ip}) {as} {provider} {country}".format(**entry))

        for entry in res['dns_records']['host']:
            if entry['reverse_dns']:
                hostRecords.append("{domain} ({reverse_dns}) ({ip}) {as} {provider} {country}".format(**entry))
            else:
                hostRecords.append("{domain} ({ip}) {as} {provider} {country}".format(**entry))

        for entry in res['dns_records']['host']:
            if entry['header']:
                if str(entry['header']).lower().__contains__('ssh'):
                    technologyFound.append("{domain} {header} - OOPS SSH port 22 may be open".format(**entry))
                else:
                    technologyFound.append("{domain} {header}".format(**entry))

        for entry in res['dns_records']['txt']:
            txtRecords.append(entry)

        allRecords.append(dnsRecords)
        allRecords.append(mxRecords)
        allRecords.append(hostRecords)
        allRecords.append(technologyFound)
        allRecords.append(txtRecords)
        
        return { 'data': allRecords }

class HealthCheck(Resource):
    def get(self):
        return 'pong'

api.add_resource(DnsDumpster, '/scan/<string:hostUrl>')
api.add_resource(HealthCheck, '/ping')

api.init_app(app)

if __name__ == '__main__':
    app.run(debug=True, port=8080, host='0.0.0.0')