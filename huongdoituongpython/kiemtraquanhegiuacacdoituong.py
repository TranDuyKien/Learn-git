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

#sử dụng hàm isinstance để kiểm tra mối quan hệ giữa các đối tượng của lớp. 
# Nó trả về true nếu đối tượng là một thể hiện của lớp và ngược lại sai trả về false
print(isinstance(result,calculation3))