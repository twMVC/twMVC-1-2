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
    [KnownType(typeof(Region))]
    [KnownType(typeof(Employees))]
    public partial class Territories: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region 基本屬性
    
        [DataMember]
        public string TerritoryID
        {
            get { return _territoryID; }
            set
            {
                if (_territoryID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("屬性 'TerritoryID' 是物件索引鍵的一部分，因此無法變更。只能在物件不加以追蹤或其處在已加入狀態，才能對索引鍵屬性進行變更。");
                    }
                    _territoryID = value;
                    OnPropertyChanged("TerritoryID");
                }
            }
        }
        private string _territoryID;
    
        [DataMember]
        public string TerritoryDescription
        {
            get { return _territoryDescription; }
            set
            {
                if (_territoryDescription != value)
                {
                    _territoryDescription = value;
                    OnPropertyChanged("TerritoryDescription");
                }
            }
        }
        private string _territoryDescription;
    
        [DataMember]
        public int RegionID
        {
            get { return _regionID; }
            set
            {
                if (_regionID != value)
                {
                    ChangeTracker.RecordOriginalValue("RegionID", _regionID);
                    if (!IsDeserializing)
                    {
                        if (Region != null && Region.RegionID != value)
                        {
                            Region = null;
                        }
                    }
                    _regionID = value;
                    OnPropertyChanged("RegionID");
                }
            }
        }
        private int _regionID;

        #endregion
        #region 導覽屬性
    
        [DataMember]
        public Region Region
        {
            get { return _region; }
            set
            {
                if (!ReferenceEquals(_region, value))
                {
                    var previousValue = _region;
                    _region = value;
                    FixupRegion(previousValue);
                    OnNavigationPropertyChanged("Region");
                }
            }
        }
        private Region _region;
    
        [DataMember]
        public TrackableCollection<Employees> Employees
        {
            get
            {
                if (_employees == null)
                {
                    _employees = new TrackableCollection<Employees>();
                    _employees.CollectionChanged += FixupEmployees;
                }
                return _employees;
            }
            set
            {
                if (!ReferenceEquals(_employees, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("無法在 ChangeTracking 啟用時設定 FixupChangeTrackingCollection");
                    }
                    if (_employees != null)
                    {
                        _employees.CollectionChanged -= FixupEmployees;
                    }
                    _employees = value;
                    if (_employees != null)
                    {
                        _employees.CollectionChanged += FixupEmployees;
                    }
                    OnNavigationPropertyChanged("Employees");
                }
            }
        }
        private TrackableCollection<Employees> _employees;

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
            Region = null;
            Employees.Clear();
        }

        #endregion
        #region 關聯修復
    
        private void FixupRegion(Region previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Territories.Contains(this))
            {
                previousValue.Territories.Remove(this);
            }
    
            if (Region != null)
            {
                if (!Region.Territories.Contains(this))
                {
                    Region.Territories.Add(this);
                }
    
                RegionID = Region.RegionID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Region")
                    && (ChangeTracker.OriginalValues["Region"] == Region))
                {
                    ChangeTracker.OriginalValues.Remove("Region");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Region", previousValue);
                }
                if (Region != null && !Region.ChangeTracker.ChangeTrackingEnabled)
                {
                    Region.StartTracking();
                }
            }
        }
    
        private void FixupEmployees(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Employees item in e.NewItems)
                {
                    if (!item.Territories.Contains(this))
                    {
                        item.Territories.Add(this);
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Employees", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Employees item in e.OldItems)
                {
                    if (item.Territories.Contains(this))
                    {
                        item.Territories.Remove(this);
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Employees", item);
                    }
                }
            }
        }

        #endregion
    }
}
