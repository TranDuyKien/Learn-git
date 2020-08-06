import mymodule
import platform
import platform


x = platform.system()
print(x)


x = dir(platform)
print(x)


mymodule.greeting("Jonathan")


#Mô-đun có thể chứa các hàm, như đã được mô tả, 
# nhưng cũng có các biến của tất cả các loại (mảng, từ điển, đối tượng, v.v.):

from mymodule import person1
print(person1["age"])



