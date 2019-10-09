package com.book.entity;

/**
 * @author 17683
    *     用户实体类
 */
public class User {
	
	private Integer id;
	private String name;
	private String email;
	private String phone;
	private String password;
	private String photo;
	private String address;
	private int state;
	public int getState() {
		return state;
	}
	public void setState(int state) {
		this.state = state;
	}
	public int getId() {
		return id;
	}
	public void setId(Integer id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	public String getPhoto() {
		return photo;
	}
	public void setPhoto(String photo) {
		this.photo = photo;
	}
	
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	public User(Integer id, String name, String email, String phone, String password, String photo, String address,
			int state) {
		super();
		this.id = id;
		this.name = name;
		this.email = email;
		this.phone = phone;
		this.password = password;
		this.photo = photo;
		this.address = address;
		this.state = state;
	}
	public User(Integer id, String name, String phone, String email, String password, String photo, String address) {
		super();
		this.id = id;
		this.name = name;
		this.phone = phone;
		this.email = email;
		this.password = password;
		this.photo = photo;
		this.address = address;
	}
	public User(String name, String password) {
		super();
		this.name = name;
		this.password = password;
	}
	public User() {
		super();
	}


	
	
	
	
	
	

}
