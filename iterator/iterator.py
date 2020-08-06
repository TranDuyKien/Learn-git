#Phương thức __iter__ trả về chính đối tượng iterator. Phương thức này được yêu cầu cài đặt cho cả đối tượng "iterable" và iterator để có thể sử dụng các câu lệnh for và in.
#Phương thức __next__ trả về phần tử tiếp theo. Nếu không còn phần tử nào nữa thì sẽ có lỗi StopIteration xảy ra.
#Khai báo list
my_list=[1,2,3,4,5,6]
#Lấy iterator bằng cách sử dụng iter
my_iter = my_list.__iter__()

#Cách 1 đưa ra phần tử 
#Đưa ra phần tử thứ nhất
print(next(my_iter))
#Đưa ra phần tử thứ hai
print(next(my_iter))


#Cách 1 đưa ra phần tử 
print(my_iter.__next__())
print(my_iter.__next__())