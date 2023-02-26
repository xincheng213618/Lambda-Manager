import redis
HOST = "127.0.0.1"
USER = 'root'
PASSWD = 'xincheng'
DB = 'grid'
PORT = 6379
CHARSET = 'utf8'
import uuid
if __name__ == '__main__':
    r = redis.Redis(host=HOST, port=PORT, decode_responses=True)
    print(r)
    print(r.get('xincheng213618@gmail.com'))
    r.set('xincheng213618@gmail.com', str(uuid.uuid1())[:6],px=6000000)
    print(r.get('xincheng213618@gmail.com'))
    print()

