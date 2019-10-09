package com.book.dao;

import java.util.List;

import org.apache.ibatis.annotations.Param;

import com.book.entity.book_info;
import com.book.entity.book_type;

public interface bookMapper {
	
	
//	查找 书籍  按 类型
	public List<book_info> selectBookList(@Param("booktype")int booktype ,@Param("from")int from , @Param("pageSize")int pageSize);
	
//	详情
	public book_info selectBookProduct(@Param("no")int no);
	
//	模糊搜索
	public List<book_info> SearchBookList(@Param("name")String name);
	
//  总行数
	public int getBookCount(book_info booktype);
	
//	类型 ==> 路径导航
	public book_type selectBooktype(@Param("id")int id);
	
//	插入书籍
	public int insertBook(book_info book_info);
	
}
