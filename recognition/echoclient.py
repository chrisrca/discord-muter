import socket

HOST = "71.192.69.230"  # The server's hostname or IP address
PORT = 14578  # The port used by the server

def sendDied():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.connect((HOST, PORT))
        s.sendall(0)
        data = s.recv(1024)
        s.close()
    print(data)

def sendRoundEnd():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.connect((HOST, PORT))
        s.sendall(1)
        data = s.recv(1024)
        s.close()
    print(data)