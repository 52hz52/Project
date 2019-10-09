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
 *  2019 - 9 - 16 分页
 *
 */
@Controller
public class bookController {
	
	@Resource 
	private bookService bookService;
	
//	购买成功
	@RequestMapping("payOK")
	public String payOK() {
		
		return "User/payOK";
	}
	
	
//	 按类型        ==> 分页
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
//		总行数
		int totalCount = 0;
//		现在的 页面
		Integer currentPageNo = 0;
//		页面容量
		int pageSize = 8;
		
		book_info book_type = new book_info();
//	查找书籍 == 总书籍
		totalCount =  bookService.totalCount(book_type);
		
		book_info book_type2 = new book_info();
		book_type2.setBooktype(id);
//		查找书籍数量  按照 类型
		int book_info_type =  bookService.totalCount(book_type2);
		
//		当前页码
		currentPageNo = 1;
		if(pageIndex != 0) {
				
			try {
				currentPageNo = pageIndex;
				System.out.println("现在页码："+currentPageNo);
			} catch (Exception e) {
				// TODO: handle exception
			}
		}

//		总页数
		page = new PageTool();	
		page.setCurrentPageNo(currentPageNo);
		page.setPageSize(pageSize);
		page.setTotalCount(book_info_type);
		int totalPageCount = page.getTotalPageCount();
		System.out.println("容量："+pageSize);
		System.out.println("总页数："+totalPageCount);
		
//		控制首页 和 尾页
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
		
		
//		总页数
		session.setAttribute("page", page);
		
//		分页信息
		session.setAttribute("totalCount",totalCount);
//		现在选择类型书籍的数量
		session.setAttribute("book_info_type", book_info_type);
		
//		路径导航
		session.setAttribute("booktype", booktype);
		
		model.addAttribute("Book_infos",Book_infos);
		model.addAttribute("pageIndex",pageIndex);
		return "User/index";
	}
	
	
//	书籍详情
	  
	  @RequestMapping("bookProduct")
	  public String bookPro(Model model ,  HttpServletRequest request) {
	  		
		  int no = Integer.parseInt(request.getParameter("pro_id"));
		  System.out.println("详情书籍编号:   =================>  "+no); 
		  
		  book_info Book_pro = bookService.bookProduct(no);
		  	  
		  model.addAttribute("Book_pro",Book_pro);
		  
		  System.out.println("======>  书籍详情");
		  return "User/Product"; 
	  
	  
	  }
	  
	
// 购买书籍
	  
	  @RequestMapping("bookBuys") 
	  public String bookBuy(Model model ,HttpServletRequest request){ 
		  int no =  Integer.parseInt(request.getParameter("buy_id"));
		  System.out.println("购买书籍编号:   =================>  "+no);
		  book_info Book_buy = bookService.bookProduct(no);
		  model.addAttribute("Book_buy",Book_buy);
	  
		  return "User/buyBook"; 
		  
	  }
	  
	  
//	  搜索书籍
	  @RequestMapping(value="/SearchBook",method = RequestMethod.POST)
	  
	  public String SearchBook(Model model ,HttpServletRequest request,String book_name) {
		  List<book_info> Book_infos = null;
		  if(book_name!=null) {
			  System.out.println("搜索书籍 书名+======>  "+book_name);
			  Book_infos =   bookService.SearchBooks(book_name);
		  }
		  
		  model.addAttribute("Book_infos",Book_infos);
		  
		  return "User/index";
	  }
	 
	
	
	
	
	
	
	
	
	
	

}
