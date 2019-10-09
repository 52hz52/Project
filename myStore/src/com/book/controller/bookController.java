package com.book.controller;
 
import java.util.List;
import javax.annotation.Resource;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;

import com.book.entity.book_info;
import com.book.entity.book_type;
import com.book.service.bookService;
import com.book.tool.PageTool;


/**
 * @author Administrator
 *  2019 - 9 - 16 ��ҳ
 *
 */
@Controller
public class bookController {
	
	@Resource 
	private bookService bookService;
	
//	����ɹ�
	@RequestMapping("payOK")
	public String payOK() {
		
		return "User/payOK";
	}
	
	
//	 ������        ==> ��ҳ
	@RequestMapping("findbook")
	public String findbook(Model model,HttpServletRequest request ) {

		String temp = request.getParameter("pageIndex");
		String n_id = request.getParameter("id");
		String o_id = "1";
		if(n_id!=null) {
			o_id = n_id;
		}
		
		
		if(temp == null) {		
			temp = "1";
		}	
		
		int id = Integer.parseInt(o_id) ;
		System.out.println("====> "+id);
		
		
		int pageIndex = Integer.parseInt(temp);
		System.out.println("pageIndex:===>"+pageIndex);
		
		
		
		
		PageTool page = null;
//		������
		int totalCount = 0;
//		���ڵ� ҳ��
		Integer currentPageNo = 0;
//		ҳ������
		int pageSize = 8;
		
		book_info book_type = new book_info();
//	�����鼮 == ���鼮
		totalCount =  bookService.totalCount(book_type);
		
		book_info book_type2 = new book_info();
		book_type2.setBooktype(id);
//		�����鼮����  ���� ����
		int book_info_type =  bookService.totalCount(book_type2);
		
//		��ǰҳ��
		currentPageNo = 1;
		if(pageIndex != 0) {
				
			try {
				currentPageNo = pageIndex;
				System.out.println("����ҳ�룺"+currentPageNo);
			} catch (Exception e) {
				// TODO: handle exception
			}
		}

//		��ҳ��
		page = new PageTool();	
		page.setCurrentPageNo(currentPageNo);
		page.setPageSize(pageSize);
		page.setTotalCount(book_info_type);
		int totalPageCount = page.getTotalPageCount();
		System.out.println("������"+pageSize);
		System.out.println("��ҳ����"+totalPageCount);
		
//		������ҳ �� βҳ
		if(currentPageNo < 1) {
			currentPageNo = 1;
		}else if(currentPageNo > totalPageCount) {
			currentPageNo = totalPageCount;
		}
		
		
		List<book_info> Book_infos =  bookService.findbookList(id,currentPageNo-1, pageSize);
		book_type booktype =  bookService.selectbookType(id);
		
		
		for (book_info book_info : Book_infos) {
			System.out.println(book_info.getPhoto()+"    <=====> " +book_info.getAuthor() );
		}
	
		
		HttpSession session = request.getSession();
		
		
//		��ҳ��
		session.setAttribute("page", page);
		
//		��ҳ��Ϣ
		session.setAttribute("totalCount",totalCount);
//		����ѡ�������鼮������
		session.setAttribute("book_info_type", book_info_type);
		
//		·������
		session.setAttribute("booktype", booktype);
		
		model.addAttribute("Book_infos",Book_infos);
		model.addAttribute("pageIndex",pageIndex);
		return "User/index";
	}
	
	
//	�鼮����
	  
	  @RequestMapping("bookProduct")
	  public String bookPro(Model model ,  HttpServletRequest request) {
	  		
		  int no = Integer.parseInt(request.getParameter("pro_id"));
		  System.out.println("�����鼮���:   =================>  "+no); 
		  
		  book_info Book_pro = bookService.bookProduct(no);
		  	  
		  model.addAttribute("Book_pro",Book_pro);
		  
		  System.out.println("======>  �鼮����");
		  return "User/Product"; 
	  
	  
	  }
	  
	
// �����鼮
	  
	  @RequestMapping("bookBuys") 
	  public String bookBuy(Model model ,HttpServletRequest request){ 
		  int no =  Integer.parseInt(request.getParameter("buy_id"));
		  System.out.println("�����鼮���:   =================>  "+no);
		  book_info Book_buy = bookService.bookProduct(no);
		  model.addAttribute("Book_buy",Book_buy);
	  
		  return "User/buyBook"; 
		  
	  }
	  
	  
//	  �����鼮
	  @RequestMapping(value="/SearchBook",method = RequestMethod.POST)
	  
	  public String SearchBook(Model model ,HttpServletRequest request,String book_name) {
		  List<book_info> Book_infos = null;
		  if(book_name!=null) {
			  System.out.println("�����鼮 ����+======>  "+book_name);
			  Book_infos =   bookService.SearchBooks(book_name);
		  }
		  
		  model.addAttribute("Book_infos",Book_infos);
		  
		  return "User/index";
	  }
	 
	
	
	
	
	
	
	
	
	
	

}
