package PetShop.dao;

import java.util.List;

import PetShop.entity.Master;

/**
 * ���˽ӿ�
 * @author Administrator
 *
 */
public interface MasterDao {
	/**
	 * ���˵�¼
	 */
	Master MasterQuery(Master master);
	
	/**
	 * ��������
	 */
	int MasterAdd(Master master);
	
	/**
	 * �����޸�
	 */
	int MasterUpdate(Master master);
	// ��ѯ����������Ϣ
	List<Master> getPetOwner();
}
