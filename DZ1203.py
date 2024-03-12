def arithmetic_operational(a):
    if a == '+':
        return lambda x, y: x + y
    elif a == '-':
        return lambda x, y: x - y
    elif a == '*':
        return lambda x, y: x * y
    elif a == '/':
        return lambda x, y: x / y
    elif a == '//':
        return lambda x, y: x // y

def same_by(a, b):
    c = 0
    d = a(b[0])
    for i in b:
        if a(i) != d:
            return False
    return True

a310 = input('Введите номер: ')
if a310 == '3':  
    a = input().split()
    cla = []
    for i in a:
        cla.append(i.lower())
    print(a, cla)
    cla.sort()
    ca = []
    for i in cla:
        for j in a:
            if i == j.lower():
                ca.append(j)
    print(' '.join(ca))
elif a310 == '4':
    mxvls = []
    for i in range(int(input())):
        mxcls = 0
        for j in range(int(input())):
            a = input().split()
            if int(a[1]) > mxcls:
                mxcls = int(a[1])
        mxvls.append(mxcls)
    if all(i==5 for i in mxvls):
        print('ДА')
    else:
        print('НЕТ')
elif a310 == '5':
    b = []
    a = input()
    if a == '':
        print(-1)
    else:
        a = int(a)
        b.append(a)
        while True:
            c = 0
            for i in b:
                c+=i
            c = c / len(b)
            print(c)
            a = int(input())
            b.append(a)
elif a310 == '6':
    b = 0
    while True:
        a = input().split()
        for i in a:
            if i == '0' and b == 0:
                print(True)
                b = 88005553535


