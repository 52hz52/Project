package cn.microboom.entity;

/**
 * 未来天气实体类
 * @author Administrator
 *
 */
public class Future {
	
	private String timDate;//日期
	private String week;//星期
	private String weather;//天气
	private String wendu;//温度
	private String pic;//天气图片名称
	public String getTimDate() {
		return timDate;
	}
	public void setTimDate(String timDate) {
		this.timDate = timDate;
	}
	public String getWeek() {
		return week;
	}
	public void setWeek(String week) {
		this.week = week;
	}
	public String getWeather() {
		return weather;
	}
	public void setWeather(String weather) {
		this.weather = weather;
	}
	public String getWendu() {
		return wendu;
	}
	public void setWendu(String wendu) {
		this.wendu = wendu;
	}
	public String getPic() {
		return pic;
	}
	public void setPic(String pic) {
		this.pic = pic;
	}
	public Future(String timDate, String week, String weather, String wendu, String pic) {
		super();
		this.timDate = timDate;
		this.week = week;
		this.weather = weather;
		this.wendu = wendu;
		this.pic = pic;
	}
	public Future() {
		super();
	}
	
	

}
