--��Ҫͨ���洢���̺��������
use IQQ

--1.ע�Ṧ��
	--1)�������ݵ�Customer��
	--2)����Ĭ�Ϸ������ݵ�FriendGroup��(3��������Ҫ3���������)
	insert into Customer
	(NickName,Pass,Sex,BornDate,RegDate,Head,[Level],Idiograph,Caption,CName,EName,Language,BloodType,Profession,Educational,		School,Phone,Mobile,Email,HomePage,NativePlace,LocationPlace,Address,Postcode,Status)
	values
	('������','123456','��','1993-05-18','2004-2-25','�ڹ�',35,'','','','','��������','A��','ѧ��','','','','12345678910','','',''	,'�ɶ�','','',1)

	insert into Customer
	(NickName,Pass,Sex,BornDate,RegDate,Head,[Level],Idiograph,Caption,CName,EName,Language,BloodType,Profession,Educational,		School,Phone,Mobile,Email,HomePage,NativePlace,LocationPlace,Address,Postcode,Status)
	values
	('�','123456','��','1993-05-18','2004-2-25','�ڹ�',35,'','','','','��������','A��','ѧ��','','','','12345678910','','',''	,'�ɶ�','','',1)
	
	insert into Customer
	(NickName,Pass,Sex,BornDate,RegDate,Head,[Level],Idiograph,Caption,CName,EName,Language,BloodType,Profession,Educational,		School,Phone,Mobile,Email,HomePage,NativePlace,LocationPlace,Address,Postcode,Status)
	values
	('��Ȼ','123456','��','1993-05-18','2004-2-25','�ڹ�',35,'','','','','��������','A��','ѧ��','','','','12345678910','','',''	,'�ɶ�','','',1)		
	
--2.��½����
	--�õ�������Ϣ
	--�õ����ѷ���
	--�õ�ÿ�������µ���Ա�б�
	--�õ�Ⱥ��Ϣ	
	--�õ�δ������Ϣ
	
--3.�������ѷ���
	--1)�������ݵ����ѷ����FriendGroup��
	--2)��ѯ������ӵĺ��ѷ�����Ϣ
                                                                                                                      
--4.����Ⱥ
	--1)�������ݵ�Ⱥ��GroupInfo��
	--2)��ѯ������ӵ�Ⱥ��Ϣ
	
--5.������ϵ��
	--ͨ��ģ����ѯ�����Ǿ�ȷ��ѯ

--6.������Ӻ��ѵ���Ϣ
	--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--2)�������ݵ�������Ϣ��PersonalMessage��
	
--7.ͬ����Ӻ��ѵ���Ϣ
	--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--2)�������ݵ�������Ϣ��PersonalMessage��
	--3)�������ݵ���ϵ�˱�RelationList��(��Ҫ2���������)
	--4)��ѯ����ӵ���ϵ�˵���Ϣ

--8.�ܾ���Ӻ��ѵ���Ϣ
	--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--2)�������ݵ�������Ϣ��PersonalMessage��

--9.����Ⱥ��Ϣ
	--ͨ��ģ����ѯ�����Ǿ�ȷ��ѯ
	
--10.�������Ⱥ����Ϣ
	--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--2)�������ݵ�Ⱥ��Ϣ��Ϣ��GroupMessage��

--11.ͬ�����Ⱥ����Ϣ
	--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--2)�������ݵ�Ⱥ��Ϣ��Ϣ��GroupMessage��(��Ҫ�����������)
	--3)�������ݵ�Ⱥ����ϵ�˱�GroupList��
	--4)��ѯ�õ�����ӵ�Ⱥ��Ϣ

--12.�ܾ����Ⱥ����Ϣ
	--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--2)�������ݵ�Ⱥ��Ϣ��Ϣ��GroupMessage��

--13.���͸���������Ϣ
	--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--2)�������ݵ�������Ϣ��PersonalMessage��

--14.����Ⱥ������Ϣ
	--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--2)�������ݵ�Ⱥ��Ϣ��Ϣ��GroupMessage��(���ܻ��ж����������)
	
--15.ɾ����ϵ��
	--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--2)�������ݵ�������Ϣ��PersonalMessage��
	--3)����ϵ�˱�RelationList��ɾ������
	
--16.�˳�Ⱥ
	--)Ⱥ���˳�
		--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
		--2)�������ݵ�������Ϣ��PersonalMessage��(���ܻ��ж����������)
		--3)��Ⱥ��Ϣ��Ϣ��GroupMessage��ɾ����Ⱥ����Ϣ
		--4)��Ⱥ��GroupInfo��ɾ����Ⱥ����Ϣ
		--5)��Ⱥ����ϵ�˱�GroupList��ɾ����Ⱥ������ϵ�˵���Ϣ
	--)�������˳�
		--1)�������ݵ���Ϣ��Ϣ��MessageInfo��
		--2)�������ݵ�Ⱥ��Ϣ��Ϣ��GroupMessage��(���ܻ��ж����������)
		--3)��Ⱥ����ϵ�˱�GroupList��ɾ�����˵���Ϣ
	
--17.�ƶ���ϵ�˵���һ��������
	--1)�޸���ϵ�˱�RelationList�е���Ϣ
	
--18.ɾ�����ѷ���
	--1)�޸���ϵ�˱�RelationList�е���Ϣ��Ĭ�Ϸ����ҵĺ�����
	--2)ɾ�����ѷ����FriendGroup�и÷������Ϣ
	--3)��ѯĬ�Ϸ����еĺ�����Ϣ

--19.���¸�����Ϣ
	--1)����QQ�û���Customer�е�����
	--2)ͨ����ѯ�����µ�ǰ����Ϣ
	
--20.�޸���ϵ�˵ı�ע����
	--1)������ϵ�˱�RelationList�е���Ϣ
	--2)ͨ����ѯ�����µ�ǰ����Ϣ
	
--21.�޸�Ⱥ��Ƭ
	--1)����Ⱥ����ϵ�˱�GroupList�е���Ϣ
	--2)ͨ����ѯ�����µ�ǰ����Ϣ
	
--22.�޸�����״̬
	--1)����QQ�û���Customer�е�����
	--2)�������ݵ���Ϣ��Ϣ��MessageInfo��
	--3)�������ݵ�������Ϣ��PersonalMessage��
	--4)��ѯ��ǰ���µ���Ϣ
