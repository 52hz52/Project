package com.book.dao;

import java.util.List;

import org.apache.ibatis.annotations.Param;

import com.book.entity.book_info;
import com.book.entity.book_type;

public interface bookMapper {
	
	
//	���� �鼮  �� ����
	public List<book_info> selectBookList(@Param("booktype")int booktype ,@Param("from")int from , @Param("pageSize")int pageSize);
	
//	����
	public book_info selectBookProduct(@Param("no")int no);
	
//	ģ������
	public List<book_info> SearchBookList(@Param("name")String name);
	
//  ������
	public int getBookCount(book_info booktype);
	
//	���� ==> ·������
	public book_type selectBooktype(@Param("id")int id);
	
//	�����鼮
	public int insertBook(book_info book_info);
	
}
