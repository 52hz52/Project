package com.book.service.impl;

import java.util.List;

import javax.annotation.Resource;

import org.springframework.stereotype.Service;

import com.book.dao.bookMapper;
import com.book.entity.book_info;
import com.book.entity.book_type;
import com.book.service.bookService;
@Service("bookService")
public class bookServiceImpl implements bookService {

	@Resource
	private bookMapper bookMapper;
	
	
	@Override
	public List<book_info> findbookList(int booktype,int from,int pageSize) {
		// TODO Auto-generated method stub
		return bookMapper.selectBookList(booktype,from*8,pageSize);
	}


	@Override
	public book_info bookProduct(int no) {
		// TODO Auto-generated method stub
		return bookMapper.selectBookProduct(no);
	}


	@Override
	public int totalCount(book_info booktype) {
		// TODO Auto-generated method stub
		return bookMapper.getBookCount(booktype);
	}


	@Override
	public List<book_info> SearchBooks(String name) {
		// TODO Auto-generated method stub
		return bookMapper.SearchBookList(name);
	}


	@Override
	public book_type selectbookType(int id) {
		// TODO Auto-generated method stub
		return bookMapper.selectBooktype(id);
	}


	@Override
	public int setBookinfo(book_info book_info) {
		// TODO Auto-generated method stub
		return bookMapper.insertBook(book_info);
	}

}
