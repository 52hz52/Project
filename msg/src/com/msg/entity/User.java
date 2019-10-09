package com.msg.entity;
import java.io.Serializable;
public class User implements Serializable {
	private Integer uid;
	public Integer getUid() {
		return uid;
	}
	public void setUid(Integer uid) {
		this.uid = uid;
	}

	private String username;
	private String password;
	private String email;
	
	public String getUsername() {
		return username;
	}
	public void setUsername(String username) {
		this.username = username;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	
	public User() {
		// TODO Auto-generated constructor stub
	}
	
	public User(Integer uid , String username, String password, String email) {
		super();
		this.uid =uid;
		this.username = username;
		this.password = password;
		this.email = email;
	}
	
	

}
