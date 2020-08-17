class student:

    def __init__(self, name, id):
        self.id = id
        self.name = name
        
    def display(self):
        print("Student ID: %s \nName: %s" % (self.id, self.name))

st1 = student("john",1)
st2 = student("nathan",2)

st1.display()

st2.display()
