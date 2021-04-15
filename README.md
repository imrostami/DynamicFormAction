# DynamicFormAction
Send dynamic data from one form in  to another form in WinForm and access it very easily


# How To Use

This library is very easy to use And there are three simple ways to communicate and exchange information dynamically between forms

1.Add **DynamicAction.cs** File To Project

2.Add **DynamicFormActionPlug** using to your project





# Let's test it
Add two forms to your project to test



# Example to use

in Form1 To display Form 2, we act normally 
But to send data, we set the Action method: 

```csharp
var f2 = new Form2();
f2.Action("data1" , "data2" , "data3");
f2.Show();
```

Display data:
In Form 2, we use the **GetFormAction** method to display the data
```csharp
//in form 2
this.GetFormAction();

```


# Note 

The ```Action``` method receives data in ``` params dynamic ```

And the``` GetFormAction ```method also outputs the current form Action Data ```dynamic[]```




# Description of methods

|             Method Name             |              Description              |                                           Use                                          |   
|:-----------------------------------:|:-------------------------------------:|:--------------------------------------------------------------------------------------:|--
| Action("data1" , "data2" , "data3") | Set Action Data to a Form             | ```var f2 = new Form2(); f2.Action("data1" , "data2" , "data3"); f2.Show(); ``` |   
| GetFormAction(form instance)        | Get Form Action with Form Instance    |  ``` GetFormAction(new Form2()); ```                                             |   
| RemoveFormFromActionList            | Remove Form Action with Form instance | RemoveFormFromActionList(new Form2)                                                    |  
|                                     |                                       |                                                                                        |   
