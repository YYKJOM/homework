#include<iostream>
using namespace std; 
int main()
{
	int judge=-1;
	float cm=0,inch=0; 
	while(judge)
	{
		cout<<"请输入序号选择功能"<<endl<<"0.结束程序"<<endl<<"1.厘米转英寸"<<endl<<"2.英寸转厘米"<<endl;
		cin>>judge;
		switch(judge)
		{
			case 0:
				break;
			case 1:
				cout<<"请输入厘米"<<endl;
				cin>>cm;
				cout<<cm<<"厘米为"<<cm*0.3937<<"英寸"<<endl; 
				break;
			case 2:
				cout<<"请输入英寸"<<endl;
				cin>>inch;
				cout<<inch<<"英寸为"<<inch*2.54<<"厘米"<<endl; 
				break;
			default:
				cout<<"请输入正确数字"<<endl;
		}
	} 
}
