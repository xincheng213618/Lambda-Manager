from flask import Flask

from .init_error_views import init_error_views

def init_plugs(app: Flask) -> None:
    init_error_views(app)
