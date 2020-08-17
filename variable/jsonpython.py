import json


#VÍ DỤ 1
# some JSON:
# x = '{ "name":"John", "age":30, "city":"New York"}'
# # parse x:
# y = json.loads(x)

# # the result is a Python dictionary:
# print(y["city"])




#VÍ DỤ 2
#a python dictionary
# x={
#     "name":"john",
#     "age":"30",
#     "city":"NewYork"
# }
# #Convert dictonary to json
# y = json.dumps(x)
# print(y)


#VÍ DỤ 3


# print(json.dumps({"name":"john","age":"30"}))
# print(json.dumps(["banana","orange"]))
# print(json.dumps(("apple","banana")))
# print(json.dumps("hello"))
# print(json.dumps(42))
# print(json.dumps(31.76))
# print(json.dumps(True))
# print(json.dumps(False))
# print(json.dumps(None))



#Ví dụ 4

x = {
  "name": "John",
  "age": 30,
  "married": True,
  "divorced": False,
  "children": ("Ann","Billy"),
  "pets": None,
  "cars": [
    {"model": "BMW 230", "mpg": 27.5},
    {"model": "Ford Edge", "mpg": 24.1}
  ]
}

# convert into JSON:
y = json.dumps(x)

# the result is a JSON string:
print(y)
