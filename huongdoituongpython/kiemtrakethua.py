class calculation1:
    def sum(self,a,b):
        return a+b
class calculation2:
    def multiplication(self,a,b):
        return a*b
class calculation3(calculation1,calculation2):
    def divide(self,a,b):
        return a/b
result = calculation3()

#sử dụng hàm issubclass để kiểm tra kế thừa nếu đúng trả về true nếu sai trả về false
print(issubclass(calculation3,calculation1))