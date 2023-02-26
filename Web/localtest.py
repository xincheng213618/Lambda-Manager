
from main import *

if __name__ == '__main__':
    server.register_blueprint(web_interface, url_prefix='/web-interface')
    server.run(debug=True, port=18888, host='0.0.0.0');