#Tạo ra một lớp có hàm tính tổng
class calculation1:
    def sum(self,a,b):
        return a+b
#Tạo ra một lớp có hàm tính tích
class calculation2:
    def multiplication(self,a,b):
        return a*b
#Tạo lớp tính phép chia nhưng đa kế thừa từ 2 lớp trên
class divide(calculation1, calculation2):
    def divided(self,a,b):
        return a/b
dvd = divide()
print(dvd.sum(10,2))
print(dvd.multiplication(10,2))
print(dvd.divided(10,2))