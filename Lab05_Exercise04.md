# Lab 5 Exercise 4

## Fields declaration and initialization


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex04
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var myObj = new MyClass();

System.Console.WriteLine($"Default integer      F1 = {myObj.F1}");  //Implicit fields initialization
System.Console.WriteLine($"Default string       F2 = {myObj.F2}");
System.Console.WriteLine($"Initialized integer  F3 = {myObj.F3}");  //Explicit field initialization
System.Console.WriteLine($"Initialized string   F4 = {myObj.F4}");

class MyClass
{
    public int F1;
    public string F2;
    public int F3 = 100;
    public string F4 = "ASDF";
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex04
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/051c327d-f55e-4fd8-b8ca-d474199db3f0)


7. อธิบายสิ่งที่พบในการทดลอง
- มีการสร้างobjectของclass และแสดงผลลัพธ์การเข้าถึงfield F1 F2 F3 F4 ของobject F1,F2 ไม่ได้ระบุค่าจึงเป็นค่า
ของชนิดข้อมูลแต่ F3,F4 มีการกำหนดค่าเริ่มต้นมีค่าเป็น 100,ASDF
