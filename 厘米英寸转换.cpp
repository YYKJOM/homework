#include<iostream>
using namespace std; 
int main()
{
	int judge=-1;
	float cm=0,inch=0; 
	while(judge)
	{
		cout<<"���������ѡ����"<<endl<<"0.��������"<<endl<<"1.����תӢ��"<<endl<<"2.Ӣ��ת����"<<endl;
		cin>>judge;
		switch(judge)
		{
			case 0:
				break;
			case 1:
				cout<<"����������"<<endl;
				cin>>cm;
				cout<<cm<<"����Ϊ"<<cm*0.3937<<"Ӣ��"<<endl; 
				break;
			case 2:
				cout<<"������Ӣ��"<<endl;
				cin>>inch;
				cout<<inch<<"Ӣ��Ϊ"<<inch*2.54<<"����"<<endl; 
				break;
			default:
				cout<<"��������ȷ����"<<endl;
		}
	} 
}
