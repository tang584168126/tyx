package PetShop.dao;

import java.util.List;

import PetShop.entity.Pet;

/**
 * ����ӿ�
 * @author Administrator
 *
 */
public interface PetDao {
	/**
	 * ��������
	 */
	int PetAdd(Pet pet);
	
	/**
	 * �����޸�
	 */
	int PetUpdate(Pet pet);
	
	/**
	 * ����ɾ��
	 */
	int PetDelete(Pet pet);
	
	/**
	 * �����ѯ
	 */
	 List<Pet> select();
}
