package com.book.tool;
 /**
 * @author Administrator
 * ��ҳ������
 *
 */
public class PageTool {
	
//	��ǰҳ�� - �����û�����
	private int currentPageNo = 1;
	
//	������ ���� total  =  ��
	private int totalCount = 0;
	
//	ҳ������
	private int pageSize = 0;

//	��ҳ��          �������� / ҳ������  (+1)
	private int totalPageCount = 1;

//	�õ����ڵ�ҳ������
	public int getCurrentPageNo() {
		return currentPageNo;
	}
	
//	����ҳ��
	public void setCurrentPageNo(int currentPageNo) {
		if(currentPageNo>0) {
			this.currentPageNo = currentPageNo;
		}
		
	}
	
//	�ô���ҳ��
	public int getTotalCount(){
		return totalCount;
	}
	
	public void setTotalCount(int totalCount) {
		if(totalCount>0) {
			this.totalCount = totalCount;
			//������ҳ��
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
//		     ������                                                      ҳ������
		if(this.totalCount % this.pageSize == 0) {
//			  ҳ����ʾ�ڼ�ҳ                                          ������                                     ҳ������
			this.totalPageCount = this.totalCount / this.pageSize;
		}else if(this.totalCount % this.pageSize > 0 ) {
			this.totalPageCount =(int)Math.ceil((this.totalCount / (double)this.pageSize) ) ; 
		}else {
			this.totalPageCount = 0;
		}
		
		
	}
	
	
	
	
	
	
}
