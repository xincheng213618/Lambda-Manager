
from main import *
from flask import  url_for


import webinterface
if __name__ == '__main__':
    server.config['MAX_CONTENT_LENGTH'] = 160 * 1000 * 1000

    server.register_blueprint(web_interface, url_prefix='/web-interface')
    server.run(debug=True, port=18888, host='0.0.0.0');
