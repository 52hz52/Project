package com.book.tool;
 /**
 * @author Administrator
 * 分页工具类
 *
 */
public class PageTool {
	
//	当前页面 - 来自用户输入
	private int currentPageNo = 1;
	
//	总数量 （表） total  =  总
	private int totalCount = 0;
	
//	页面容量
	private int pageSize = 0;

//	总页面          表中数量 / 页面容量  (+1)
	private int totalPageCount = 1;

//	得到现在的页面码数
	public int getCurrentPageNo() {
		return currentPageNo;
	}
	
//	设置页面
	public void setCurrentPageNo(int currentPageNo) {
		if(currentPageNo>0) {
			this.currentPageNo = currentPageNo;
		}
		
	}
	
//	得打总页面
	public int getTotalCount(){
		return totalCount;
	}
	
	public void setTotalCount(int totalCount) {
		if(totalCount>0) {
			this.totalCount = totalCount;
			//设置总页数
			this.setTotalPageCountByRs();
		}
			
	}
	
	public int getPageSize() {
		return pageSize;
	}
	
	public void setPageSize(int pageSize) {
		if(pageSize > 0){
			this.pageSize = pageSize;
		}
	}

	public int getTotalPageCount() {
		return totalPageCount;
	}

	public void setTotalPageCount(int totalPageCount) {
		this.totalPageCount = totalPageCount;
	}
	
	public void setTotalPageCountByRs() {
//		     总数量                                                      页面容量
		if(this.totalCount % this.pageSize == 0) {
//			  页面显示第几页                                          总数量                                     页面容量
			this.totalPageCount = this.totalCount / this.pageSize;
		}else if(this.totalCount % this.pageSize > 0 ) {
			this.totalPageCount =(int)Math.ceil((this.totalCount / (double)this.pageSize) ) ; 
		}else {
			this.totalPageCount = 0;
		}
		
		
	}
	
	
	
	
	
	
}
