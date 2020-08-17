class animal:
    def sound(self):
        print("Some a sound ")
class dog(animal):
    def bark(self):
        print("gou gou")
adog = dog()
adog.sound()
adog.bark()