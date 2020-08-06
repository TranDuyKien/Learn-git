b=0
x = lambda a,c: a+b
print(x(4,6))
#lambda function 
def myfunction(n):
    return lambda a: a*n
result = myfunction(5)
print(result(5))
