package petShop.dao;

import java.util.List;

import petShop.entity.Pet;

/**
 * ����ӿ�
 * @author Administrator
 *
 */
public interface PetDao {
	
	/**
	 * ��������
	 */
	public abstract int getaddpet(String sql, Object[] param);
	
	/**
	 * ��ѯ���г�����Ϣ
	 */
	public abstract List<Pet> getAllPet();
	
	/**
	 * ���³�����Ϣ
	 */
	public abstract int updatePet(String sql, Object[] param);
}
