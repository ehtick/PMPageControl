# PMPage Control ���ڹ�����

![](./resource/InsertLine.png)

## һ.���

һ���������ٴ���SolidWorks PMPage��WPF��ܺͿؼ���

## ��.ʹ��

��WPFһ��������xaml�ж���ؼ�����,���伴�á�

```xml
<page:SldPMPage x:Class="PMPageWindow.PageSample"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:PMPageWindow"
             xmlns:page="clr-namespace:Du.PMPage.Wpf;assembly=Du.PMPage.Wpf"
             mc:Ignorable="d" 
             d:DesignHeight="600" d:DesignWidth="400" PageTitle="sld">
    <page:SldPMPage.Resources>
        
    </page:SldPMPage.Resources>
    <StackPanel>
        <TabControl>
            <TabItem Header="ģ��">
                <StackPanel>
                    <ComboBox/>
                    <TextBox/>
                </StackPanel>
            </TabItem>
            <TabItem Header="gdsfg">
                <StackPanel>
                    <Expander Header="dsaf">
                        <TextBox>dsfsd</TextBox>
                    </Expander>
                    <Expander Header="dsaf">
                        <TextBox>dsfsd</TextBox>
                    </Expander>
                </StackPanel>
            </TabItem>
        </TabControl>
    </StackPanel>
</page:SldPMPage>

```

Ȼ��ʵ����������ShowPage()

```csharp
PMPageWindow.PageSample sample = new PMPageWindow.PageSample(SwApp);
sample.ShowPage();
```

## ��.������

* 1.SelectionBox
* 2.SolidWorks ���Ŀؼ�
* 3.taskpane
* 3.����nuget

## Contact me: 
email: 1831197727@qq.com
QQȺ: 715259600