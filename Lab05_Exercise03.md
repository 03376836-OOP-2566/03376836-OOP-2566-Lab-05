# Lab 5 Exercise 3

## การควบคุมการเข้าถึงสมาชิกในคลาส (fields)


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex03
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person p = new Person();
p.name = "Rambo";
p.id = "1987";
p.income = 2500;
System.Console.WriteLine($"Type of p is {p.GetType()}");
System.Console.WriteLine($"p.name = {p.name}\ttype = {p.name.GetType()}");
System.Console.WriteLine($"p.id = {p.id}\ttype = {p.id.GetType()}");
System.Console.WriteLine($"p.income = {p.income}\ttype = {p.income.GetType()}");

class Person
{
    public string? name;
    public string? id;
    public int income;
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex03
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/f9929bba-4dcb-4629-95f0-6e3084e47a6e)



7. อธิบายสิ่งที่พบในการทดลอง
- มีการสร้าง object ของclass person และมีการกำหนดค่าให้กับ field 

