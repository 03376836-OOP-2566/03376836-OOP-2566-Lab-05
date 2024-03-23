# Lab 5 Exercise 6

## Method with parameter 


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex06
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var mc = new MyClass();
mc.DisplayParam(3, 4);
class MyClass
{
    public void DisplayParam(int a, int b)
    {
        System.Console.WriteLine($"a = {a}, b = {b}");
    } 
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex06
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="553" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-05/assets/144195963/75ab6101-b7cc-4355-a8f4-abbea8c818bc">

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex06
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="515" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-05/assets/144195963/2a164109-a003-4449-b8db-1d9e970f32e6">

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล a = 3, b = 4 เพราะการกำหนด Method ด้วย parameter
