# Lab 5 Exercise 7

## Method with parameter and return value


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex07
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var adder = new MyProgram();
int x = 2, y = 3;
int add_result = adder.add(x, y);
System.Console.WriteLine($"{x} + {y} = {add_result}");

int i = 2, j = 3;
int multiply_result = adder.multiply(i, j);
System.Console.WriteLine($"{i} x {j} = {multiply_result}");

class MyProgram
{
    public int add(int a, int b)
    {
        return a + b;
    }
    public int multiply(int a, int b)
    {
        return a * b;
    }
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex07
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 ![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/01dff1eb-b39a-4ca2-a8ed-219410d727d6)


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex07
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5 ![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/3d040d72-b153-48eb-b5a8-c8b712500378)



7. อธิบายสิ่งที่พบในการทดลอง
- method add() จะทำการบวกตัวเลขที่รับเข้ามาและmethod multiply()จะทำการคูณตัวเลขทั้งสองตัวที่รับเข้ามา คำนวณผลออกมาได้ค่า 5,6 ตามลำดับ
