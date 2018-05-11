package exam.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import com.cdqy.dao.BaseDao;

import exam.dao.carDao;
import exam.entity.Car;

/**
 * 车实现类
 * @author Administrator
 *
 */
public class carDaoImpl extends BaseDao implements carDao {

	@Override
	public int add(Car car) {
		// 连接对象
		Connection conn = getConnection();
		// sql语句
		String sql = "insert into [Car] (cardId,dateTime,shiId,strain,price,money,coefficient,xmoney) values ('?',default,'?','?',?,?,?,?)";
		
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			ps.setString(1, car.getCardId());
			ps.setString(2, car.getId());
			ps.setString(3, car.getStrain());
			ps.setDouble(4, car.getPrice());
			ps.setDouble(5, car.getMoney());
			ps.setDouble(6, car.getCoefficient());
			if(car.getCoefficient() <= 1.6){
				ps.setDouble(7, car.getMoney()/(1+0.17)*0.075);
			}else{
				ps.setDouble(7, car.getMoney()/(1+0.17)*0.1);
			}
			
			return ps.executeUpdate();
		} catch (SQLException e) {
			e.printStackTrace();
		}finally {
			closeAll(conn, ps, null);
		}
		
		return 0;
	}
	
}
