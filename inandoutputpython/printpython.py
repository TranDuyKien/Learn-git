#Có thể nhập các parameter vào hàm print với số lượng bất kỳ
print("kteam","free education", "one more argument")



#Nếu cố gắng nối chuỗi với một số sẽ xảy ra lỗi can only concatenate str (not "int") to str
# print("My age "+23)
#Để sửa lỗi trên bằng cách python casting (chỉ định một biến)
print("My age "+str(23))

#hàm print có thể tự phân biệt các kiểu dữ liệu được truyền vào trong chuỗi
print(123, [4,5,6],"kteam")

#sep(separate  - phân chia)
#giá trị mặc định của parameter là một khoảng trắng ta có thể thay đổi bằng parameter sep
print("hi","everybody",sep="---")



#Một loại parameter khác end
print("a line without newline",end='')
print()

#Sử dụng thư viện time để tạm dừng chương trình trong khoảng thời gian quy định 
from time import sleep
# print("start...")
# sleep(3)
# print("end...")


#Khi kết hợp hàm sleep trong thư viện time và parameter end trong hàm print
# print("start...",end='')
# sleep(2)
# print("end...")

a = "Hello I'm your assistance"
for x in a:
    print(x,end='',flush=True)
    sleep(0.15)