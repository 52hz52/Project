package com.book.service;

import java.util.List;

import com.book.entity.book_info;
import com.book.entity.book_type;

/**
 * @author 17683
 * 查找书籍 按类型
 * 2019-9-5
 * 
 *
 */
public interface bookService {

	
	public List<book_info> findbookList(int booktype,int from , int pageSize);
	
	public book_info bookProduct(int no);
	
	public List<book_info> SearchBooks(String name);
	
	public int totalCount(book_info booktype);
	
	public book_type selectbookType(int id);
	
	public int setBookinfo(book_info book_info);
	
	
}
