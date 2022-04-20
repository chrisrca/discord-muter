import socket

HOST = "71.192.69.230"  # Standard loopback interface address (localhost)
PORT = 14578  # Port to listen on (non-privileged ports are > 1023)

while(True):
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.bind((HOST, PORT))
        s.listen()
        conn, addr = s.accept()
        with conn:
            print(f"Connected by {addr}")
            while True:
                data = conn.recv(1024)
                if not data:
                    break
                f = open("data.txt", "w")
                f.write(data)
                f.close()
                conn.sendall(data)