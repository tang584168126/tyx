package petShop.dao;

import java.util.List;

import petShop.entity.Master;


/**
 * ���ˣ��ӿ�
 * @author Administrator
 *
 */
public interface MasterDao {
	
	/**
	 * ��ѯ���г���������Ϣ
	 */
	public abstract List<Master> getAllOwner();

	/**
	 * ���³���������Ϣ
	 */
	public abstract int updateOwner(String sql, String[] param);

	/**
	 * ���ݲ�ѯ������ѯ����������Ϣ
	 */
	public abstract Master selectOwner(String sql, String[] param);

}
