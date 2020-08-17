class student:
    def __init__(self, name):
        print("Đây là constructor có tham số")
        self.name=name
    def getinfor(self):
        print("Tham số đầu tiên: "+self.name)
st1= student("john")
st1.getinfor()