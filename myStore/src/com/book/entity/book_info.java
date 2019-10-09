package com.book.entity;

public class book_info {
	
	private int no;
	private String name;
	private String photo;
	private String author;
	private String house;
	private String time;
	private String bookinfo;
	private double price;
	private double disprice;
	private int booktype;
	private int attrbute;
	
	public int getNo() {
		return no;
	}
	public void setNo(int no) {
		this.no = no;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getPhoto() {
		return photo;
	}
	public void setPhoto(String photo) {
		this.photo = photo;
	}
	public String getAuthor() {
		return author;
	}
	public void setAuthor(String author) {
		this.author = author;
	}
	public String getHouse() {
		return house;
	}
	public void setHouse(String house) {
		this.house = house;
	}
	public String getTime() {
		return time;
	}
	public void setTime(String time) {
		this.time = time;
	}
	public String getBookinfo() {
		return bookinfo;
	}
	public void setBookinfo(String bookinfo) {
		this.bookinfo = bookinfo;
	}
	public double getPrice() {
		return price;
	}
	public void setPrice(double price) {
		this.price = price;
	}
	public double getDisprice() {
		return disprice;
	}
	public void setDisprice(double disprice) {
		this.disprice = disprice;
	}
	public int getBooktype() {
		return booktype;
	}
	public void setBooktype(int booktype) {
		this.booktype = booktype;
	}
	public int getAttrbute() {
		return attrbute;
	}
	public void setAttrbute(int attrbute) {
		this.attrbute = attrbute;
	}
	public book_info(String name, String photo, String author, String house, String time, String bookinfo, double price,
			double disprice, int booktype, int attrbute) {
		super();
		this.name = name;
		this.photo = photo;
		this.author = author;
		this.house = house;
		this.time = time;
		this.bookinfo = bookinfo;
		this.price = price;
		this.disprice = disprice;
		this.booktype = booktype;
		this.attrbute = attrbute;
	}
	public book_info() {
		super();
	}
	
	
	
	

}
