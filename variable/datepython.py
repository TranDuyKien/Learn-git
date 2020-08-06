import datetime


x= datetime.datetime.now()
print(x)
print("Today is: ",x.year)
y=datetime.datetime.today()
print(y)

#Lấy ra ngày hiện tại
print(y.strftime("%A"))
#Lấy ra tháng hiện tại
print(y.strftime("%B"))
#Lấy ra hai số cuối của năm hiện tại
print(y.strftime("%C"))
#lấy ra tháng, ngày, năm hiện tại
print(y.strftime("%D"))