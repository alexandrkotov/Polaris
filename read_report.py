import json


with open('report.json') as json_file:
    data = json.load(json_file)
    print(data)
