//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     變更這個檔案可能會導致不正確的行為，而且如果已重新產生
//     程式碼，這個檔案將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace TWMVC.Models
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Categories))]
    [KnownType(typeof(Order_Details))]
    [KnownType(typeof(Suppliers))]
    public partial class Products: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region 基本屬性
    
        [DataMember]
        public int ProductID
        {
            get { return _productID; }
            set
            {
                if (_productID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("屬性 'ProductID' 是物件索引鍵的一部分，因此無法變更。只能在物件不加以追蹤或其處在已加入狀態，才能對索引鍵屬性進行變更。");
                    }
                    _productID = value;
                    OnPropertyChanged("ProductID");
                }
            }
        }
        private int _productID;
    
        [DataMember]
        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (_productName != value)
                {
                    _productName = value;
                    OnPropertyChanged("ProductName");
                }
            }
        }
        private string _productName;
    
        [DataMember]
        public Nullable<int> SupplierID
        {
            get { return _supplierID; }
            set
            {
                if (_supplierID != value)
                {
                    ChangeTracker.RecordOriginalValue("SupplierID", _supplierID);
                    if (!IsDeserializing)
                    {
                        if (Suppliers != null && Suppliers.SupplierID != value)
                        {
                            Suppliers = null;
                        }
                    }
                    _supplierID = value;
                    OnPropertyChanged("SupplierID");
                }
            }
        }
        private Nullable<int> _supplierID;
    
        [DataMember]
        public Nullable<int> CategoryID
        {
            get { return _categoryID; }
            set
            {
                if (_categoryID != value)
                {
                    ChangeTracker.RecordOriginalValue("CategoryID", _categoryID);
                    if (!IsDeserializing)
                    {
                        if (Categories != null && Categories.CategoryID != value)
                        {
                            Categories = null;
                        }
                    }
                    _categoryID = value;
                    OnPropertyChanged("CategoryID");
                }
            }
        }
        private Nullable<int> _categoryID;
    
        [DataMember]
        public string QuantityPerUnit
        {
            get { return _quantityPerUnit; }
            set
            {
                if (_quantityPerUnit != value)
                {
                    _quantityPerUnit = value;
                    OnPropertyChanged("QuantityPerUnit");
                }
            }
        }
        private string _quantityPerUnit;
    
        [DataMember]
        public Nullable<decimal> UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (_unitPrice != value)
                {
                    _unitPrice = value;
                    OnPropertyChanged("UnitPrice");
                }
            }
        }
        private Nullable<decimal> _unitPrice;
    
        [DataMember]
        public Nullable<short> UnitsInStock
        {
            get { return _unitsInStock; }
            set
            {
                if (_unitsInStock != value)
                {
                    _unitsInStock = value;
                    OnPropertyChanged("UnitsInStock");
                }
            }
        }
        private Nullable<short> _unitsInStock;
    
        [DataMember]
        public Nullable<short> UnitsOnOrder
        {
            get { return _unitsOnOrder; }
            set
            {
                if (_unitsOnOrder != value)
                {
                    _unitsOnOrder = value;
                    OnPropertyChanged("UnitsOnOrder");
                }
            }
        }
        private Nullable<short> _unitsOnOrder;
    
        [DataMember]
        public Nullable<short> ReorderLevel
        {
            get { return _reorderLevel; }
            set
            {
                if (_reorderLevel != value)
                {
                    _reorderLevel = value;
                    OnPropertyChanged("ReorderLevel");
                }
            }
        }
        private Nullable<short> _reorderLevel;
    
        [DataMember]
        public bool Discontinued
        {
            get { return _discontinued; }
            set
            {
                if (_discontinued != value)
                {
                    _discontinued = value;
                    OnPropertyChanged("Discontinued");
                }
            }
        }
        private bool _discontinued;

        #endregion
        #region 導覽屬性
    
        [DataMember]
        public Categories Categories
        {
            get { return _categories; }
            set
            {
                if (!ReferenceEquals(_categories, value))
                {
                    var previousValue = _categories;
                    _categories = value;
                    FixupCategories(previousValue);
                    OnNavigationPropertyChanged("Categories");
                }
            }
        }
        private Categories _categories;
    
        [DataMember]
        public TrackableCollection<Order_Details> Order_Details
        {
            get
            {
                if (_order_Details == null)
                {
                    _order_Details = new TrackableCollection<Order_Details>();
                    _order_Details.CollectionChanged += FixupOrder_Details;
                }
                return _order_Details;
            }
            set
            {
                if (!ReferenceEquals(_order_Details, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("無法在 ChangeTracking 啟用時設定 FixupChangeTrackingCollection");
                    }
                    if (_order_Details != null)
                    {
                        _order_Details.CollectionChanged -= FixupOrder_Details;
                        // 這是在關聯中執行串聯刪除的主體端點。
                        // 為目前集合中的任何實體移除串聯刪除事件處理常式。
                        foreach (Order_Details item in _order_Details)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _order_Details = value;
                    if (_order_Details != null)
                    {
                        _order_Details.CollectionChanged += FixupOrder_Details;
                        // 這是在關聯中執行串聯刪除的主體端點。
                        // 為已存在於新集合的任何實體加入串聯刪除事件處理常式。
                        foreach (Order_Details item in _order_Details)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("Order_Details");
                }
            }
        }
        private TrackableCollection<Order_Details> _order_Details;
    
        [DataMember]
        public Suppliers Suppliers
        {
            get { return _suppliers; }
            set
            {
                if (!ReferenceEquals(_suppliers, value))
                {
                    var previousValue = _suppliers;
                    _suppliers = value;
                    FixupSuppliers(previousValue);
                    OnNavigationPropertyChanged("Suppliers");
                }
            }
        }
        private Suppliers _suppliers;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        // 此實體類型是在至少一個會執行串聯刪除的關聯中的相依端點。
        // 此事件處理常式將處理刪除主體端點時所發生的通知。
        internal void HandleCascadeDelete(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                this.MarkAsDeleted();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            Categories = null;
            Order_Details.Clear();
            Suppliers = null;
        }

        #endregion
        #region 關聯修復
    
        private void FixupCategories(Categories previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Products.Contains(this))
            {
                previousValue.Products.Remove(this);
            }
    
            if (Categories != null)
            {
                if (!Categories.Products.Contains(this))
                {
                    Categories.Products.Add(this);
                }
    
                CategoryID = Categories.CategoryID;
            }
            else if (!skipKeys)
            {
                CategoryID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Categories")
                    && (ChangeTracker.OriginalValues["Categories"] == Categories))
                {
                    ChangeTracker.OriginalValues.Remove("Categories");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Categories", previousValue);
                }
                if (Categories != null && !Categories.ChangeTracker.ChangeTrackingEnabled)
                {
                    Categories.StartTracking();
                }
            }
        }
    
        private void FixupSuppliers(Suppliers previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Products.Contains(this))
            {
                previousValue.Products.Remove(this);
            }
    
            if (Suppliers != null)
            {
                if (!Suppliers.Products.Contains(this))
                {
                    Suppliers.Products.Add(this);
                }
    
                SupplierID = Suppliers.SupplierID;
            }
            else if (!skipKeys)
            {
                SupplierID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Suppliers")
                    && (ChangeTracker.OriginalValues["Suppliers"] == Suppliers))
                {
                    ChangeTracker.OriginalValues.Remove("Suppliers");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Suppliers", previousValue);
                }
                if (Suppliers != null && !Suppliers.ChangeTracker.ChangeTrackingEnabled)
                {
                    Suppliers.StartTracking();
                }
            }
        }
    
        private void FixupOrder_Details(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Order_Details item in e.NewItems)
                {
                    item.Products = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Order_Details", item);
                    }
                    // 這是在關聯中執行串聯刪除的主體端點。
                    // 將事件接聽程式更新為參考新的相依端點。
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Order_Details item in e.OldItems)
                {
                    if (ReferenceEquals(item.Products, this))
                    {
                        item.Products = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Order_Details", item);
                        // 刪除識別關聯的相依端點。如果其目前狀態為 Added，
                        // 則可變更關聯性而不會造成此相依端點被刪除。
                        if (item.ChangeTracker.State != ObjectState.Added)
                        {
                            item.MarkAsDeleted();
                        }
                    }
                    // 這是在關聯中執行串聯刪除的主體端點。
                    // 從事件接聽程式移除先前的相依端點。
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }

        #endregion
    }
}
