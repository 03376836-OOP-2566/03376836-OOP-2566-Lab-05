# Lab 5 Exercise 5

## simple Method


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex05
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/83302624-0575-4583-a82b-2908b5bcdc78)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var myObj = new MyClass();
myObj.Info();

class MyClass
{
    int F1;
    string F2;
    int F3 = 100;
    string F4 = "ASDF";

    public void Info()
    {
        System.Console.WriteLine($"Default integer      F1 = {F1}");  //Implicit fields initialization
        System.Console.WriteLine($"Default string       F2 = {F2}");

        System.Console.WriteLine($"Initialized integer  F3 = {F3}");  //Explicit field initialization
        System.Console.WriteLine($"Initialized string   F4 = {F4}");
    } 
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/e27d30ab-8d95-44b5-a3e4-744e08fc4e1a)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex05
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/c0a78e31-1366-4dba-b6a2-c2997fbe2918)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/0f683f7a-0a0f-443a-a120-dd21e6c74c29)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/1060f572-c39a-4fae-99d2-7d36bb4a9ef5)


7. อธิบายสิ่งที่พบในการทดลอง

การทดลองนี้ เราสร้างอ็อบเจกต์ของคลาส MyClass และเรียกใช้เมทอด Info() ซึ่งจะแสดงค่าของฟิลด์ทั้งหมดของอ็อบเจกต์นั้น

ในคลาส MyClass เรามีฟิลด์ 4 ฟิลด์คือ F1, F2, F3, และ F4 ซึ่งมีการกำหนดค่าต่างกันดังนี้:

 F1 และ F2 ไม่ได้กำหนดค่าเริ่มต้น 
F3 กำหนดค่าเริ่มต้นให้เป็น 100 
 F4 กำหนดค่าเริ่มต้นให้เป็น "ASDF" 

เมื่อเรียกใช้เมทอด Info() จะแสดงค่าของฟิลด์ทั้งหมด ซึ่ง F1 และ F2 จะแสดงค่าเริ่มต้นสำหรับชนิดข้อมูลนั้น ๆ ซึ่งคือ 0 สำหรับ int และ null สำหรับ string และ F3 และ F4 จะแสดงค่าที่เรากำหนดไว้ในการกำหนดค่าเริ่มต้น explcitly
ผลลัพธ์ที่ได้ก็จะเป็นตามภาพ
Default integer      F1 = 0
Default string       F2 = 
Initialized integer  F3 = 100
Initialized string   F4 = ASDF

ผลลัพธ์นี้แสดงถึงค่าของฟิลด์ทั้งหมดในอ็อบเจกต์ myObj ตามที่กำหนดในคลาส MyClass ผ่านการเรียกใช้เมทอด Info()


