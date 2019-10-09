package com.book.entity;

public class Admin_user {
	
	private int a_id;
	private String a_name;
	private String a_email;
	private String a_phone;
	private String a_password;
	public int getA_id() {
		return a_id;
	}
	public void setA_id(int a_id) {
		this.a_id = a_id;
	}
	public String getA_name() {
		return a_name;
	}
	public void setA_name(String a_name) {
		this.a_name = a_name;
	}
	public String getA_email() {
		return a_email;
	}
	public void setA_email(String a_email) {
		this.a_email = a_email;
	}
	public String getA_phone() {
		return a_phone;
	}
	public void setA_phone(String a_phone) {
		this.a_phone = a_phone;
	}
	public String getA_password() {
		return a_password;
	}
	public void setA_password(String a_password) {
		this.a_password = a_password;
	}
	public Admin_user(int a_id, String a_name, String a_email, String a_phone, String a_password) {
		super();
		this.a_id = a_id;
		this.a_name = a_name;
		this.a_email = a_email;
		this.a_phone = a_phone;
		this.a_password = a_password;
	}
	public Admin_user(String a_name, String a_email, String a_phone, String a_password) {
		super();
		this.a_name = a_name;
		this.a_email = a_email;
		this.a_phone = a_phone;
		this.a_password = a_password;
	}
	public Admin_user(String a_name, String a_password) {
		super();
		this.a_name = a_name;
		this.a_password = a_password;
	}
	public Admin_user() {
		super();
	}

	
	
	
}
