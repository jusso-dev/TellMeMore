# TellMeMore
Web app to collectively preform reconnaissance on web hosted solutions

## Build status
[![Build status](https://dev.azure.com/JustinMiddler/TellMeMore/_apis/build/status/TellMeMore-CI)](https://dev.azure.com/JustinMiddler/TellMeMore/_build/latest?definitionId=9)

## Features

- Qualys SSL Labs Scan
- urlscan.io Scan
- dnsdumpster Scan
- BuiltWith Scan
- Bulk Scan (all sites) Scan
- PDF export - (coming soon..)
- Excel export - (coming soon..)

## Instructions

- Open .sln file
- Restore and Build sln/project
- Go to https://urlscan.io and sign up for a free API key
- Go to https://api.builtwith.com/free-api and sign up for a free API key
- Go to https://www.google.com/recaptcha/admin and get new V2 "invisible" recaptcha client key
- Ensure API keys are in application.Development.json file
- cd to /TellMeMore/dnsdumpster-api and run 'pip install requirements.txt' and 'uvicorn main:app --reload' to run locally, will start on port 8000 by default
- F5 run project

<br />
<img src='site.jpg' alt='site-image-missing'>