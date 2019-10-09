package com.msg.entity;

import java.io.Serializable;
import java.sql.Timestamp;


public class Message implements Serializable {
	
	private Integer msgid; //消息编号
	private String username; //发送者
	private String title; //标题
	private String msgcontent;  //消息内容
	private Integer state; // 已读、未读 状态
	private String sendto;//接收者
	private Timestamp msgCreateDate;//消息创建的时间
	public Integer getMsgid() {
		return msgid;
	}
	public void setMsgid(Integer msgid) {
		this.msgid = msgid;
	}
	public String getUsername() {
		return username;
	}
	public void setUsername(String username) {
		this.username = username;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public String getMsgcontent() {
		return msgcontent;
	}
	public void setMsgcontent(String msgcontent) {
		this.msgcontent = msgcontent;
	}
	public Integer getState() {
		return state;
	}
	public void setState(Integer state) {
		this.state = state;
	}
	public String getSendto() {
		return sendto;
	}
	public void setSendto(String sendto) {
		this.sendto = sendto;
	}
	public Timestamp getMsgCreateDate() {
		return msgCreateDate;
	}
	public void setMsgCreateDate(Timestamp msgCreateDate) {
		this.msgCreateDate = msgCreateDate;
	}
	public Message(Integer msgid, String username, String title, String msgcontent, Integer state, String sendto,
			Timestamp msgCreateDate) {
		super();
		this.msgid = msgid;
		this.username = username;
		this.title = title;
		this.msgcontent = msgcontent;
		this.state = state;
		this.sendto = sendto;
		this.msgCreateDate = msgCreateDate;
	}
	public Message() {
		super();
	}
	
	
	
}
