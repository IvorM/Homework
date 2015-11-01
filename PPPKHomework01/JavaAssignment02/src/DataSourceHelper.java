import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import javax.sql.DataSource;
/**
 *
 * @author Ivor
 */
public class DataSourceHelper {
    public static DataSource createDataSource() {
        SQLServerDataSource dataSource = new SQLServerDataSource();
        dataSource.setServerName("");
        dataSource.setDatabaseName("PPPK");
        dataSource.setUser("");
        dataSource.setPassword("");
        return dataSource;
    }
}
