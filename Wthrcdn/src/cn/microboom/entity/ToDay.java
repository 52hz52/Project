package cn.microboom.entity;

/**
 * ��������ʵ���࣬�����������������Ϣ
 * @author Administrator
 *
 */
public class ToDay {
	
	private String cityName;//����
	private String timDate;//����
	private String week;//����
	private String weather;//����
	private String wendu;//�¶�
	private String fengli;//����
	private String fengxiang;//����
	private String ganmao;//��ðָ��
	private String pic;//����ͼƬ����
	public String getCityName() {
		return cityName;
	}
	public void setCityName(String cityName) {
		this.cityName = cityName;
	}
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
	public String getFengli() {
		return fengli;
	}
	public void setFengli(String fengli) {
		this.fengli = fengli;
	}
	public String getFengxiang() {
		return fengxiang;
	}
	public void setFengxiang(String fengxiang) {
		this.fengxiang = fengxiang;
	}
	public String getGanmao() {
		return ganmao;
	}
	public void setGanmao(String ganmao) {
		this.ganmao = ganmao;
	}
	public String getPic() {
		return pic;
	}
	public void setPic(String pic) {
		this.pic = pic;
	}
	public ToDay(String cityName, String timDate, String week, String weather, String wendu, String fengli,
			String fengxiang, String ganmao, String pic) {
		super();
		this.cityName = cityName;
		this.timDate = timDate;
		this.week = week;
		this.weather = weather;
		this.wendu = wendu;
		this.fengli = fengli;
		this.fengxiang = fengxiang;
		this.ganmao = ganmao;
		this.pic = pic;
	}
	public ToDay() {
		super();
	}
}
