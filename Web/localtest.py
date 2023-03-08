
from main import *
from flask import  url_for


import webinterface
if __name__ == '__main__':
    app.config['MAX_CONTENT_LENGTH'] = 160 * 1000 * 1000
    if os.environ.get('WERKZEUG_RUN_MAIN') == 'true':
        print("test")
    app.register_blueprint(web_interface, url_prefix='/web-interface')
    app.run(debug=True, port=18888, host='0.0.0.0');
