from fastapi import FastAPI
from dnsdumpster.DNSDumpsterAPI import DNSDumpsterAPI
import json

app = FastAPI()

@app.get("/")
async def root(hostUrl: str):

    dnsRecords = []
    mxRecords = []
    hostRecords = []
    technologyFound = []
    txtRecords = []

    allRecords = []

    if hostUrl == None:
        raise HTTPException(
            status_code=404, 
            detail="Please pass a host url in the query string. 'hostUrl url parameter missing."
        )

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

    return str(returnObj)