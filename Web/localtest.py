
from main import *
from flask import  url_for
from applications import add_app
from flask_migrate import Migrate
from applications.extensions import db
from applications.configs import config

if __name__ == '__main__':
    # if os.environ.get('WERKZEUG_RUN_MAIN') == 'true':

    config_name = os.getenv('FLASK_CONFIG', 'development')
    app.config.from_object(config[config_name])
    migrate = Migrate(app, db)
    add_app(app)
    app.run(debug=True, port=18888, host='0.0.0.0');
