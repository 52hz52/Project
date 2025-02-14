
package cn.microboom.entity;

import java.io.Serializable;

public class Forecast implements Serializable{
	 private String date;
	 private String high;
	 private String fengli;
	 private String low;
	 private String fengxiang;
	 private String type;
	 private String img;
	public String getImg() {
		return img;
	}
	public void setImg(String img) {
		this.img = img;
	}
	public String getDate() {
		return date;
	}
	public void setDate(String date) {
		this.date = date;
	}
	public String getHigh() {
		return high;
	}
	public void setHigh(String high) {
		this.high = high;
	}
	public String getFengli() {
		return fengli;
	}
	public void setFengli(String fengli) {
		this.fengli = fengli;
	}
	public String getLow() {
		return low;
	}
	public void setLow(String low) {
		this.low = low;
	}
	public String getFengxiang() {
		return fengxiang;
	}
	public void setFengxiang(String fengxiang) {
		this.fengxiang = fengxiang;
	}
	public String getType() {
		return type;
	}
	public void setType(String type) {
		this.type = type;
	}
	public Forecast(String date, String high, String fengli, String low, String fengxiang, String type) {
		super();
		this.date = date;
		this.high = high;
		this.fengli = fengli;
		this.low = low;
		this.fengxiang = fengxiang;
		this.type = type;
	}
	public Forecast(String date, String high, String fengli, String low, String fengxiang, String type, String img) {
		super();
		this.date = date;
		this.high = high;
		this.fengli = fengli;
		this.low = low;
		this.fengxiang = fengxiang;
		this.type = type;
		this.img = img;
	}
	public Forecast() {
		super();
	}
	@Override
	public String toString() {
		return "Forecast [date=" + date + ", high=" + high + ", fengli=" + fengli + ", low=" + low + ", fengxiang="
				+ fengxiang + ", type=" + type + "]";
	}
	 
}
