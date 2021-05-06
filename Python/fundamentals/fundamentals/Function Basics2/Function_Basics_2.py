# 1 countdown
num = ()
def count_down(num):
    for num in range(num, -1, -1):
        print(num)
count_down(5)

# 2 print and return
def print_and_return(a,b):
    print(a)
    return b
print_and_return(5,4)

# 3 First plus length
list = [1,2,3,4,5]
a = 0
b = 0
def first_plus_length():
    a = list[0]
    b = len(list)
    return(a+b)
print(first_plus_length())

# 4 values greater than second
list1 = [1,2,3,5,6,2,1]
greater_than = list1[1]
length = len(list1)
def values_greater_than_second(list):
    if length < 2:
        return False
    new_list = []
    for i in list:
        if i > greater_than:
            new_list.append(i)
    print(len(new_list))
    return new_list
print(values_greater_than_second(list1))



#5 this length, that value
def length_and_value(length, value):
    list1 = []
    for i in range(length):
        list1.append(value)
    return list1
print(length_and_value(5,6))