def myfucntion():
    print("Hello ")
myfucntion()


def newfunction(fname):
    print("Hello "+fname)
    return fname
newfunction("john")


lista= [["a"],"b","c"]
def bestanswer(answer):
    print("The bes answer is "+answer[2])
bestanswer(lista)


#Thêm ** vào trước tham số khi tồn tại biến không xác định 
def my_function(**kid):
  print("His last name is " + kid["fname"] + kid["kfname"] )

my_function(fname = "Tobias", kfname = "nissan", lname = "Refsnes")

#đệ quy
def tr_recursion(k):
    if (k > 0):
        result = k + tr_recursion(k-1)
        print(result)
    else:
        result = 0
        print(result)
    return result
print("Result recursion")
tr_recursion(3)

