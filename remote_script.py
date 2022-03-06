import os
import json
import platform


remote_directory = '/home/user/polaris_showcase'
os.chdir(remote_directory)

data = {
    'tytle' : 'This file was generated by remote_script.py on remote host',
    'machine' : platform.machine(),
    'version' : platform.version(),
    'platform' : platform.platform(),
    'name' : platform.uname(),
    'system' : platform.system(),
    'processor' : platform.processor()

}


json_string = json.dumps(data, indent=4)
print(json_string)

with open('report.json','w') as outfile:
    json.dump(json_string, outfile)
    outfile.close()